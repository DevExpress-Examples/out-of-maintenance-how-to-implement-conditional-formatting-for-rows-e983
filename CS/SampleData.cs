// Developer Express Code Central Example:
// How to implement conditional formatting for rows
// 
// The following sample demonstrates how to change the appearance of grid rows
// based on some condition. For example, in this tutorial you can see that the
// background color of grid rows is gradually changed based on the value in the
// second data column.
// This is done by binding the Background property of a style,
// assigned to a row, to a color converter. This converter is represented by the
// ColorValueConverter class that implements the IValueConverter interface and
// returns a color according to the provided numerical value.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E983

using DevExpress.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ConditionalRowFormatting {
    public class SimpleDataList : ObservableCollection<SimpleData> {
        protected int _InitCount;
        public int InitCount
        {
            get
            {
                return this._InitCount;
            }

            set
            {
                if (this._InitCount != value)
                {
                    this._InitCount = value;
                    Populate();
                    OnPropertyChanged(new PropertyChangedEventArgs("InitCount"));
                }
            }
        }

        void Populate() {
            Clear();
            for(int i = 0; i < InitCount; i++)
                Add(new SimpleData("Row " + i, i));
        }


    }
    public class SimpleData : BindableBase{

        protected string _Text;
        public string Text
        {
            get { return this._Text; }
            set { this.SetProperty(ref this._Text, value, "Text"); }
        }

        protected int _Int;
        public int Int
        {
            get { return this._Int; }
            set { this.SetProperty(ref this._Int, value, "Int"); }
        }
        public SimpleData() { }
        public SimpleData(string str, int num) {
            Text = str;
            Int = num;
        }
    }
}
