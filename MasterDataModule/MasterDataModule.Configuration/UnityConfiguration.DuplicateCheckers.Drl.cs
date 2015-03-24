﻿






using MasterDataModule.Lib.DuplicateCheckers.Drl;
using MasterDataModule.Lib.DuplicateCheckers.Interfaces;
using Microsoft.Practices.Unity;

namespace MasterDataModule.Configuration
{
    public static partial class UnityConfiguration
    {
        private static void InitializeDrlDuplicateCheckers(IUnityContainer container)
        {
            container.RegisterType<IDrlDuplicateChecker, ExamClassDuplicateChecker>("examClass", new PerRequestLifetimeManager());
        }

    }
}