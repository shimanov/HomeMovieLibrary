using System.Collections.Generic;

namespace MovieAPI.Models
{
    public class MovieModel
    {
        public int Vote_count { get; set; }
        /// <summary>
        /// ID Фильма
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наличие Видео
        /// </summary>
        public bool Video { get; set; }

        public double Vote_average { get; set; }
        /// <summary>
        /// Название фильма
        /// </summary>
        public string Title { get; set; }
        public double Popularity { get; set; }

        /// <summary>
        /// Путь для постера
        /// </summary>
        public string Poster_path { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public List<int> Genre_ids { get; set; }

        /// <summary>
        /// Фоновое иображение
        /// </summary>
        public string Backdrop_path { get; set; }
        public bool Adult { get; set; }

        /// <summary>
        /// Описание фильма
        /// </summary>
        public string Overview { get; set; }

        /// <summary>
        /// Мировая дата выхода
        /// </summary>
        public string Release_date { get; set; }
    }

    public class RootObjectMovie
    {
        public int Page { get; set; }

        /// <summary>
        /// Количество результатов в выдаче
        /// </summary>
        public int Total_results { get; set; }

        /// <summary>
        /// Страниц в выдаче
        /// </summary>
        public int Total_pages { get; set; }
        public List<MovieModel> Results { get; set; }
    }
}
