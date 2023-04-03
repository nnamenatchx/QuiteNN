class Program {
    static void Main(){
         double[] numbers = new double[1000];
        int count = 0; 
        string mode;

        string input;
        do {
            Console.Write("Enter a number or 'End' to stop: ");
            input = Console.ReadLine();

            if (input != "End") {
                numbers[count] = double.Parse(input);
                count++;
            }
        } while (input != "End");
    }
}