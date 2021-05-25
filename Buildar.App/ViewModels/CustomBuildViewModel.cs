using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Buildar.App.DataAccess;
using Buildar.App.Helpers;
using Buildar.Model;
using Buildar.Model.Parts;
using Microsoft.Data.SqlClient;

namespace Buildar.App.ViewModels
{
    public class CustomBuildViewModel : Observable
    {

        private ObservableCollection<BuildPart> buildparts = new ObservableCollection<BuildPart>();
        public ObservableCollection<BuildPart> Buildparts { get { return this.buildparts; } }

        public ObservableCollection<Cpu> Cpus { get; set; } = new ObservableCollection<Cpu>();

        public readonly Cpus cpusDataAccess = new Cpus();
        

        public CustomBuildViewModel()
        {
            

            this.buildparts.Add(new BuildPart() { Part = "CPU", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/cpu.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "GPU", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/gpu.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "MEMORY", PartImage= "https://itstud.hiof.no/~steinhs/subjects/netImgs/memory.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "MOTHERBOARD", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/motherboard.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "STORAGE", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/ssd.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "POWERSUPPLY", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/psu2.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "CASE", PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/case.jpg" });
            this.buildparts.Add(new BuildPart() { Part = "COOLER",  PartImage = "https://itstud.hiof.no/~steinhs/subjects/netImgs/cooler.jpg" });
        }


        internal async Task LoadCpusAsync()
        {
            var cpus = await cpusDataAccess.GetCpusAsync();
            if (cpus == null)
            {
                foreach (Cpu cpu in cpus)
                        Cpus.Add(cpu);
            }

        }

        //TEMP TESTER
        public ObservableCollection<Cpu> GetCpus(string connectionString)
        {
            const string GetCpusQuery = "select * from Cpus";
            var cpus = new ObservableCollection<Cpu>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetCpusQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var cpu = new Cpu();
                                    cpu.Id = reader.GetInt32(0);
                                    cpu.Model = reader.GetString(1);
                                    cpu.Maker = reader.GetString(2);
                                    cpu.Price = reader.GetInt32(3);
                                    cpu.Cores = reader.GetInt32(4);
                                    cpu.Threads = reader.GetInt32(5);
                                    cpu.Socket = reader.GetString(5);
                                    cpu.EstWatt = reader.GetInt32(5);
                                    cpu.ImgURL = reader.GetString(5);
                                    cpus.Add(cpu);
                                }
                            }
                        }
                    }
                }
                return cpus;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }

    }
}
