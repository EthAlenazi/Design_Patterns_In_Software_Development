namespace Builder_Pattern
{

    public static class CarWizard
{
    private static readonly string[] PresetExtras =
    {
        "Rear Camera",
        "360 Camera",
        "Apple CarPlay",
        "Adaptive Cruise Control",
        "Panoramic Roof",
        "Dash Cam",
        "Heated Seats",
        "Blind Spot Monitor"
    };

    public static Car Run(ICarBuilder builder, IBuildTracer tracer)
    {
        Console.WriteLine("=== Interactive Car Builder (Wizard) ===");
        Console.WriteLine("Tip: Press Enter to accept default values.\n");

        tracer.ResetSteps();
        builder.Reset();

        var model = AskText("Model", "Custom Build");
        builder.SetModel(model);

        var engine = AskText("Engine", "2.0L");
        builder.SetEngine(engine);

        var gearbox = AskChoice(
            "Gearbox",
            new[] { "CVT", "AT (Automatic)", "MT (Manual)", "DCT" },
            defaultIndex: 2); // MT as default (just for variety)
        builder.SetGearbox(gearbox);

        var color = AskChoice(
            "Color",
            new[] { "White", "Black", "Silver", "Red", "Blue" },
            defaultIndex: 3);
        builder.SetColor(color);

        var wheels = AskInt("Wheels", 4, min: 3, max: 18);
        builder.SetWheels(wheels);

        Console.WriteLine("\n--- Extras ---");
        AddExtrasLoop(builder);

        Console.WriteLine("\n--- Finalizing ---");
        return builder.Build();
    }

    private static void AddExtrasLoop(ICarBuilder builder)
    {
        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1) Add from list");
            Console.WriteLine("2) Type custom extra");
            Console.WriteLine("3) Finish extras");

            var choice = ReadInt("Select (1-3): ", 1, 3);

            if (choice == 3) break;

            if (choice == 1)
            {
                Console.WriteLine("\nAvailable extras:");
                for (int i = 0; i < PresetExtras.Length; i++)
                    Console.WriteLine($"{i + 1}) {PresetExtras[i]}");

                var idx = ReadInt($"Pick extra (1-{PresetExtras.Length}): ", 1, PresetExtras.Length);
                builder.AddExtra(PresetExtras[idx - 1]);
            }
            else if (choice == 2)
            {
                var custom = AskText("Custom extra", "Window Tint");
                builder.AddExtra(custom);
            }
        }
    }

    private static string AskText(string label, string defaultValue)
    {
        Console.Write($"{label} (default: {defaultValue}): ");
        var input = Console.ReadLine();
        return string.IsNullOrWhiteSpace(input) ? defaultValue : input.Trim();
    }

    private static int AskInt(string label, int defaultValue, int min, int max)
    {
        Console.Write($"{label} (default: {defaultValue}, range: {min}-{max}): ");
        var input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
            return defaultValue;

        if (int.TryParse(input, out var value) && value >= min && value <= max)
            return value;

        Console.WriteLine("Invalid number. Using default.");
        return defaultValue;
    }

    private static string AskChoice(string label, string[] options, int defaultIndex)
    {
        Console.WriteLine($"{label}:");
        for (int i = 0; i < options.Length; i++)
        {
            var def = (i == defaultIndex) ? " (default)" : "";
            Console.WriteLine($"{i + 1}) {options[i]}{def}");
        }

        var chosen = ReadInt($"Select (1-{options.Length}) or Enter for default: ", 1, options.Length, allowEmpty: true);
        if (chosen == -1) return options[defaultIndex];
        return options[chosen - 1];
    }

    private static int ReadInt(string prompt, int min, int max, bool allowEmpty = false)
    {
        while (true)
        {
            Console.Write(prompt);
            var input = Console.ReadLine();

            if (allowEmpty && string.IsNullOrWhiteSpace(input))
                return -1;

            if (int.TryParse(input, out var value) && value >= min && value <= max)
                return value;

            Console.WriteLine($"Please enter a valid number ({min}-{max}).");
        }
    }
}

}
