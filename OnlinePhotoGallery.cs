
using System;
using System.Collections.Generic;

namespace PhotoGallery
{
    class Photo
    {
        public string FilePath { get; set; }
        public string Caption { get; set; }
        public DateTime DateTaken { get; set; }
    }

    class PhotoGallery
    {
        private List<Photo> photos;

        public PhotoGallery()
        {
            photos = new List<Photo>();
        }

        public void AddPhoto(Photo photo)
        {
            photos.Add(photo);
        }

        public List<Photo> GetPhotos()
        {
            return photos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PhotoGallery gallery = new PhotoGallery();

            // Add some photos to the gallery
            gallery.AddPhoto(new Photo { FilePath = "photo1.jpg", Caption = "Photo 1", DateTaken = new DateTime(2020, 1, 1) });
            gallery.AddPhoto(new Photo { FilePath = "photo2.jpg", Caption = "Photo 2", DateTaken = new DateTime(2020, 2, 1) });
            gallery.AddPhoto(new Photo { FilePath = "photo3.jpg", Caption = "Photo 3", DateTaken = new DateTime(2020, 3, 1) });

            // Display the photos in the gallery
            foreach (var photo in gallery.GetPhotos())
            {
                Console.WriteLine("File Path: " + photo.FilePath);
                Console.WriteLine("Caption: " + photo.Caption);
                Console.WriteLine("Date Taken: " + photo.DateTaken.ToString());
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}