using System.Collections.Generic;

namespace ConditionalRowFormatting {
    public class SimpleDataList : List<SimpleData> {
        private int initCount;
        public int InitCount {
            get { return this.initCount; }
            set {
                this.initCount = value;
                Populate();
            }
        }
        void Populate() {
            Clear();
            for(int i = 0; i < InitCount; i++)
                Add(new SimpleData("Row " + i, i));
        }
    }
    public class SimpleData {
        public string Text { get; set; }
        public int Int { get; set; }
        public SimpleData() { }
        public SimpleData(string str, int num) {
            Text = str;
            Int = num;
        }
    }
}
