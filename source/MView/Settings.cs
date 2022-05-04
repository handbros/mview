﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MView
{
    public class Settings : PropertyChangedBase
    {
        // Constants
        public readonly static string[] KnownExtensions = new string[] { ".png", ".ogg", ".m4a", ".wav", ".rpgmvp", ".rpgmvo", ".rpgmvm", ".rpgmvw", ".png_", ".ogg_", ".m4a_", ".wav_" };

        public readonly static string[] ImageExtensions = new string[] { ".png", ".rpgmvp", ".png_" };

        public readonly static string[] AudioExtensions = new string[] { ".ogg", ".m4a", ".wav", ".rpgmvo", ".rpgmvm", ".rpgmvw", ".ogg_", ".m4a_", ".wav_" };

        public readonly static string Path = @"data\settings.json";

        // Variables
        private bool _useDarkTheme = true;

        public bool UseDarkTheme
        {
            get => _useDarkTheme;
            set
            {
                Set(ref _useDarkTheme, value);
                App.ApplyTheme(value);
            }
        }

        private bool _useMultiThreading = true;

        public bool UseMultiThreading
        {
            get => _useMultiThreading;
            set => Set(ref _useMultiThreading, value);
        }

        private int _numberOfThreads = 4;

        public int NumberOfThreads
        {
            get => _numberOfThreads;
            set => Set(ref _numberOfThreads, value);
        }

        // Methods
        public void DeepCopyFrom(Settings settings)
        {
            UseDarkTheme = settings.UseDarkTheme;
            UseMultiThreading = settings.UseMultiThreading;
            NumberOfThreads = settings.NumberOfThreads;
        }
    }
}
