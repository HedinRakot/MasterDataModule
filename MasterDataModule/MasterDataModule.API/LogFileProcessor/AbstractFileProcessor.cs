using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using MasterDataModule.Contracts.Entities.Configuration;
using MasterDataModule.Lib.Managers.Configuration;

namespace MasterDataModule.API.LogFileProcessor
{
    /// <summary>
    /// Abstract file processor class
    /// </summary>
    public abstract class AbstractFileProcessor
    {
        /// <summary>
        /// Loads file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private IReadOnlyCollection<string> LoadFile(String path)
        {
            var result = new List<string>();
            if (!File.Exists(path))
            {
                return null;
            }
            try
            {

                using (var file = new StreamReader(path))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        if (!string.IsNullOrEmpty(line))
                        {
                            result.Add(line);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format(CultureInfo.InvariantCulture, "Can not read file {0}: {1}", path, ex.Message), ex);
            }
            return result;
        }

        /// <summary>
        /// Processes content to entities
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        protected abstract List<ApplicationLogs> ProcessData(IReadOnlyCollection<string> content);

        /// <summary>
        /// Exports entities to storage
        /// </summary>
        /// <param name="path"></param>
        /// <param name="manager"></param>
        public void Export(String path, ApplicationLogsManager manager)
        {
            var content = LoadFile(path);
            var entites = ProcessData(content);
            entites.ForEach(manager.AddEntity);
            manager.SaveChanges();
        }
    }
}
