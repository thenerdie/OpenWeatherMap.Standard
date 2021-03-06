﻿namespace OpenWeatherMap.Standard.Models
{
    /// <summary>
    /// weather model
    /// </summary>
    public class Weather : BaseModel
    {
        private int id;
        private string main, desc, icon;

        /// <summary>
        /// id
        /// </summary>
        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        /// <summary>
        /// main
        /// </summary>
        public string Main
        {
            get => main;
            set => SetProperty(ref main, value);
        }

        /// <summary>
        /// desc
        /// </summary>
        public string Description
        {
            get => desc;
            set => SetProperty(ref desc, value);
        }

        /// <summary>
        /// icon id
        /// </summary>
        public string Icon
        {
            get => icon;
            set => SetProperty(ref icon, value);
        }
    }

}
