namespace BlazorPWA.Models;

public class Device {
    public int Id { get; set; }
    public string Name { get; set; } = "Unknown";
    public double Flow { get; set; }
    public bool IsEnabled { get; set; } = true; // El estado del Toggle
    public string Icon { get; set; } = "none";
    public double Temp { get; set; }
    public int Purity { get; set; }
    public bool IsAlert { get; set; }
    public bool IsVisible { get; set; } = true; // <--- Nuevo campo
    public double UsageProbability { get; set; } // 0.0 to 1.0
    public double MaxFlowRate { get; set; } // L/min
}