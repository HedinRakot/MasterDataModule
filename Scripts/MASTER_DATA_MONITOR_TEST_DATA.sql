INSERT INTO SettingsData.dbo.MASTER_DATA_MONITOR_STATE([RECONFIGURE], RECONFIGURE_CHECKING_TIMEOUT) VALUES (1 ,10000);

INSERT INTO SettingsData.dbo.MASTER_DATA_SITE_INFO([NAME], TIMEOUT_CHECKING, SITE_PATH)
VALUES (N'Google' ,10000 ,N'google.com'),
(N'Yandex' ,10000 ,N'yandex.ru');

INSERT INTO SettingsData.dbo.MASTER_DATA_JOB_INFO(CONNECTION_STRING, TABLE_NAME, TIMEOUT_CHECKING, [NAME], JOB_NAME) 
VALUES (N'data source=.;initial catalog=TUEV_SUED_SERVER;integrated security=True;MultipleActiveResultSets=True;' ,N'dbo.SYS_JOBS_SCHEDULE' ,10000 ,N'Arge import job' ,N'Fe.ArgeImport'),
(N'data source=.;initial catalog=TUEV_SUED_SERVER;integrated security=True;MultipleActiveResultSets=True;' ,N'dbo.SYS_JOBS_SCHEDULE' ,10000 ,N'Arge export job' ,N'Fe.ArgeExport');

INSERT INTO SettingsData..MASTER_DATA_WINDOWS_SERVICE_INFO ([NAME],MACHINE_NAME,SERVICE_NAME,TIMEOUT_CHECKING) 
VALUES (N'ASP.NET state' ,N'localhost',N'aspnet_state', 10000 );

