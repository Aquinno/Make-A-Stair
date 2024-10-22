namespace MakeTriangule {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Stairs height: ");
            int height = int.Parse(Console.ReadLine());
            string stair = "#";
            string space = " ";
            for (int i = 1; i <= height; i++) {
                string spaces = String.Concat(Enumerable.Repeat(space, height - i));
                string stairs = String.Concat(Enumerable.Repeat(stair, i));
                Console.WriteLine(spaces + stairs);
            }
        }
    }
}
