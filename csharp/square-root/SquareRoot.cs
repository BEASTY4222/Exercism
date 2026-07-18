public static class SquareRoot
{
    public static int Root(int number)
    {
        int root = 0;

        while (true)
        {
            if (root * root == number) break;
            root += 1; 
        }

        return root;
    }
}
