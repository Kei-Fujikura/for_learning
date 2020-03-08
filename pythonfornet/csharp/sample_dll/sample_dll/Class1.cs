namespace sample_dll
{
    public class Class1
    {
        int mCounter = 0;

        public Class1()
        {
            mCounter = 0;
        }

        public int count()
        {
            mCounter += 1;
            return mCounter;
        }

        public void reset_count()
        {
            mCounter = 0;
        }
        public int out_count(out int c)
        {
            c = mCounter;
            return 0;
        }
        public string class_input(Class2 c2)
        {
            return c2.message;
        }
    }

    public class Class2
    {
        public string message;
        public Class2()
        {
            message = "this is class2.";
        }

    }
}
