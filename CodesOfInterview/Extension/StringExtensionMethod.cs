namespace Extension;

public static class StringExtensionMethod
{
    public static int WordCount(this string str){

        if(string.IsNullOrEmpty(str)){
            return 0;
        }

        return str.Split(new char[] { ' ','.','?'}, StringSplitOptions.RemoveEmptyEntries).Length;

    }
}
