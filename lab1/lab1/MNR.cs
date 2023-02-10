using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
   class MNR
   {
      private int NumVertices { get; set; }
      private List<List<double>> Vertices { get; set; }
      private List<double> GridX { get; set; }
      private List<double> GridY { get; set; }
      public MNR(string vertices_path, string grid_path)
      {
         using (StreamReader reader = new StreamReader(vertices_path))
         {
            this.NumVertices = int.Parse(reader.ReadLine());
            Vertices = new List<List<double>>();
            for(int i = 0; i<this.NumVertices; i++)
            {
               var line = reader.ReadLine();
               var coords = line?.Split(' ')?.Select(double.Parse)?.ToList();
               Vertices.Add(coords);
            }
         }
         using (StreamReader reader = new StreamReader(grid_path))
         {
            var line = reader.ReadLine();
            GridX = new List<double>();
            GridY = new List<double>();
            GridX = line?.Split(' ')?.Select(double.Parse)?.ToList();
            line = reader.ReadLine();
            GridY = line?.Split(' ')?.Select(double.Parse)?.ToList();
         }
      }

   }
}
