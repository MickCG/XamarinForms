﻿using ThunderForms.Services;

namespace ThunderForms.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(DataService dataService, IConventionalService conventionalService, IPlatformService platformService)
        {
            DataService = dataService;
            ConventionalService = conventionalService;
            PlatformService = platformService;
        }

        public DataService DataService { get; }
        public IConventionalService ConventionalService { get; }
        public IPlatformService PlatformService { get; }

    }
}
