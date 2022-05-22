class Control
{

    public static string[] newArray()
    {
        string[] strs = { "tolli", "liberhaus", "lol", "12", "1", "nos", "tratata",
        "fafafafa", "gohome", "ololo", "kompot", "989"};

        string[] newStrs;
        int count = 0;  

        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length <= 3) count++;
        }

        newStrs = new string[count];
        count = 0;

        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length <= 3)
            {
                newStrs[count++] = strs[i];
            }
        }

        return newStrs;
    }
}
