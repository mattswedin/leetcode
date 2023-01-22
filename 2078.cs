public class Solution
{
    public int MaxDistance(int[] colors)
    {
        int i = colors.Length - 1;
        int j = 0;
        int maxDistance = 0;
        int distance;


        while (j < colors.Length)
        {
            if (colors[i] != colors[j])
            {
                distance = i - j;
                if (maxDistance < distance) maxDistance = distance;
                j++;
            }
            else
            {
                j++;
            }

        }

        j = 0;

        while (i >= 0)
        {
            if (colors[i] != colors[j])
            {
                distance = i - j;
                if (maxDistance < distance) maxDistance = distance;
                i--;
            }
            else
            {
                i--;
            }

        }

        return maxDistance;
    }
}