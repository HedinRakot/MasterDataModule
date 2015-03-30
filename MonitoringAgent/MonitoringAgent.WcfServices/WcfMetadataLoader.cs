using System;
using System.ServiceModel.Description;

namespace MonitoringAgent.WcfServices
{
    public class WcfMetadataLoader
    {
        private readonly string url;

        public WcfMetadataLoader(string url)
        {
            this.url = url;
        }

        public PingResult Ping()
        {
            // Define the metadata address, contract name, operation name, 
            // and parameters.
            // You can choose between MEX endpoint and HTTP GET by 
            // changing the address and enum value.
            Uri mexAddress = new Uri(url);
            
            // Get the metadata file from the service.
            var mexClient = new MetadataExchangeClient(mexAddress, MetadataExchangeClientMode.HttpGet) {ResolveMetadataReferences = true};
            try
            {
                mexClient.GetMetadata();
            }
            catch (Exception ex)
            {
                return new PingResult(false, ex.Message);
            }

            //// Import all contracts and endpoints
            //WsdlImporter importer = new WsdlImporter(metaSet);
            //var contracts = importer.ImportAllContracts();
            //var allEndpoints = importer.ImportAllEndpoints();

            #region commented
            //// Generate type information for each contract
            //ServiceContractGenerator generator = new ServiceContractGenerator();
            //var endpointsForContracts = new Dictionary<string, IEnumerable<ServiceEndpoint>>();

            //foreach (ContractDescription contract in contracts)
            //{
            //    generator.GenerateServiceContractType(contract);
            //    // Keep a list of each contract's endpoints
            //    endpointsForContracts[contract.Name] = allEndpoints.Where(
            //        se => se.Contract.Name == contract.Name).ToList();
            //}

            //if (generator.Errors.Count != 0)
            //    throw new Exception("There were errors during code compilation.");

            //// Generate a code file for the contracts
            //CodeGeneratorOptions options = new CodeGeneratorOptions();
            //options.BracingStyle = "C";
            //CodeDomProvider codeDomProvider = CodeDomProvider.CreateProvider("C#");

            //// Compile the code file to an in-memory assembly
            //// Don't forget to add all WCF-related assemblies as references
            //CompilerParameters compilerParameters = new CompilerParameters(
            //    new string[]
            //    {
            //        "System.dll", "System.ServiceModel.dll",
            //        "System.Runtime.Serialization.dll"
            //    });
            //compilerParameters.GenerateInMemory = true;

            //CompilerResults results = codeDomProvider.CompileAssemblyFromDom(
            //    compilerParameters, generator.TargetCompileUnit);

            //if (results.Errors.Count > 0)
            //{
            //    throw new Exception("There were errors during generated code compilation");
            //}
            //else
            //{
            //    // Find the proxy type that was generated for the specified contract
            //    // (identified by a class that implements 
            //    // the contract and ICommunicationbject)
            //    Type clientProxyType = results.CompiledAssembly.GetTypes().First(
            //        t => t.IsClass &&
            //             t.GetInterface(contractName) != null &&
            //             t.GetInterface(typeof (ICommunicationObject).Name) != null);

            //    // Get the first service endpoint for the contract
            //    ServiceEndpoint se = endpointsForContracts[contractName].First();

            //    // Create an instance of the proxy
            //    // Pass the endpoint's binding and address as parameters
            //    // to the ctor
            //    object instance = results.CompiledAssembly.CreateInstance(
            //        clientProxyType.Name,
            //        false,
            //        System.Reflection.BindingFlags.CreateInstance,
            //        null,
            //        new object[] {se.Binding, se.Address},
            //        CultureInfo.CurrentCulture, null);

            //    // Get the operation's method, invoke it, and get the return value
            //    object retVal = instance.GetType().GetMethod(operationName).
            //        Invoke(instance, operationParameters);

            //    Console.WriteLine(retVal.ToString());
            //}
            #endregion commented

            return new PingResult(true);
        }
    }
}


