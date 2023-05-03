using System;



    class Class1
    {
        private int vikt;
        private string märke;
        private int årsmodell;
        public string mymetod_1
        {
            get
            {
                return märke;
            }
            set
            {
                märke = value;

            }


        }
        public int mymetod_2
        {
            get
            {
                return årsmodell;
            }
            set
            {
                årsmodell = value;
            }


        }
        public int mymetod_3
        {
            get { return vikt; }
            set
            {
                vikt = value;
            }
        }
    }
