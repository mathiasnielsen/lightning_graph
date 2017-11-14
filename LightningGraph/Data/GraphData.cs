using System;
namespace LightningGraph
{
    public class GraphData
    {
        public GraphData()
        {
        }

        public GraphData(string title, int graphValue)
        {
            Title = title;
            Value = graphValue;
        }

        public string Title { get; set; }
        public int Value { get; set; }
    }
}
