namespace Helg_algoritm___Jump_Game
{
    internal class Program
    {
        public static bool CanJump(int[]nums )
        { 
        int maxreach = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if (i > maxreach)
                
                 return false;

                 maxreach = Math.Max(maxreach, i + nums[i]);

                if(maxreach>= nums.Length-1)
                    return true;
                
            
            
            }
        
        return false;
        }
        static void Main(string[] args)
        {
            int[] nums1 = { 2, 3, 1, 1, 4 };
            Console.WriteLine(CanJump(nums1));

            int[] nums2 = { 3, 2, 1, 0, 4 };
            Console.WriteLine(CanJump(nums2));
        }
    }
}
