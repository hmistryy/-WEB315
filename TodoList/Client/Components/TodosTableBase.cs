using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Client.Components.Modals;
using TodoList.Client.Shared;
using TodoList.Shared.Dto;

namespace TodoList.Client.Components
{
    public class TodosTableBase : ComponentBase
    {
        [Parameter]
        public int ListId { get; set; }

        [Parameter]
        public EventCallback OnUpdated { get; set; }

        [Inject]
        protected NavigationManager NavigationManager { get; set; }

        [Inject]
        protected AppStateContainer AppState { get; set; }

        protected ListOfTodosDto ListOfTodos { get; set; }
        protected int NumberOfIncompletedTodos { get; set; }
        protected bool ListLoadFailed { get; set; }
        protected string PercentOfDoneTodos { get; set; } = "text-white";

        protected DeleteListModal DeleteListModal;
        protected EditListTitleModal EditListTitleModal;
        protected TodoDetailsModal TodoDetailsModal;

        // Property to store the filtered tasks
        protected IEnumerable<TodoDto> FilteredTodos { get; set; }


        // Define the TaskFilterOption enum
        public enum TaskFilterOption
        {
            All,
            Completed,
            Incomplete
        }

        // New property to hold the selected filter option
        protected TaskFilterOption selectedFilterOption = TaskFilterOption.All;


        protected string ProgressBarCssClass => PercentOfDoneTodos.Equals("0%") ? "text-dark" : "text-white";

        protected override void OnParametersSet()
        {
            GetListOfTodos();

            if (ListLoadFailed) return;
            GetNumberOfIncompletedTodos();
            GetPercentOfDoneTodos();

            // Filter the tasks when the component is initialized
            UpdateFilteredTaskList();
        }


        // New method to handle filter selection
        public void HandleFilterSelection(ChangeEventArgs e)
        {
            if (Enum.TryParse<TaskFilterOption>(e.Value.ToString(), out var selectedOption))
            {
                selectedFilterOption = selectedOption;
                UpdateFilteredTaskList();
            }
        }


        // New method to update the filtered list of tasks based on the selected filter
        private void UpdateFilteredTaskList()
        {
            switch (selectedFilterOption)
            {
                case TaskFilterOption.All:
                    FilteredTodos = ListOfTodos.Todos;
                    break;
                case TaskFilterOption.Completed:
                    FilteredTodos = ListOfTodos.Todos.Where(todo => todo.IsDone);
                    break;
                case TaskFilterOption.Incomplete:
                    FilteredTodos = ListOfTodos.Todos.Where(todo => !todo.IsDone);
                    break;
            }
        }
        protected void NavigateToNewListComponent()
        {
            NavigationManager.NavigateTo("lists/new");
        }

        private void GetListOfTodos()
        {
            try
            {
                var list = AppState.GetListOfTodos(ListId);

                if (list != null)
                {
                    ListOfTodos = list;
                    ListOfTodos.Todos = ListOfTodos.Todos.OrderBy(t => t.IsDone).ThenByDescending(t => t.DateAdded);
                }
                else
                {
                    ListLoadFailed = true;
                }
            }
            catch
            {
                ListLoadFailed = true;
            }

        }

        private void GetNumberOfIncompletedTodos()
        {
            NumberOfIncompletedTodos = ListOfTodos.Todos.Count(x => !x.IsDone);
        }

        private void GetPercentOfDoneTodos()
        {
            if (NumberOfIncompletedTodos == 0)
            {
                PercentOfDoneTodos = "100%";
            }
            else
            {
                var percent = (int)((ListOfTodos.Todos.Count() - NumberOfIncompletedTodos) / (ListOfTodos.Todos.Count() / 100.00));

                PercentOfDoneTodos = percent + "%";
            }
        }

        protected async Task ReloadListOfTodos()
        {
            GetListOfTodos();
            GetNumberOfIncompletedTodos();
            GetPercentOfDoneTodos();// Update the filtered list when reloading the tasks
            UpdateFilteredTaskList();

            await OnUpdated.InvokeAsync();
        }
    }
}
