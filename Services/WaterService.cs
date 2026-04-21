using BlazorPWA.Models;
using System.Threading.Tasks;

namespace BlazorPWA.Services;

public class WaterService 
{
    public List<Device> Devices = new() {
    new Device { 
        Name = "Kitchen Sink", 
        Icon = "faucet", // Icono de grifo
        MaxFlowRate = 6.0, 
        UsageProbability = 0.4 
    },
    new Device { 
        Name = "Master Shower", 
        Icon = "shower", // Icono de ducha
        MaxFlowRate = 12.0, 
        UsageProbability = 0.1 
    },
    new Device { 
        Name = "Garden Hose", 
        Icon = "yard", // Icono de planta/jardín
        MaxFlowRate = 15.0, 
        UsageProbability = 0.05 
    }
};

    public async Task ScanDevicesAsync() 
    {
        // Random delay between 1.5s and 4s to simulate network discovery
        var randomDelay = new Random().Next(1500, 4000);
        await Task.Delay(randomDelay);

        foreach (var device in Devices) {
            device.IsVisible = true;
        }
    }

    public void SimulateRealisticUsage() 
    {
        var rng = new Random();
        foreach (var device in Devices) {
            if (!device.IsEnabled) {
                device.Flow = 0;
                continue;
            }

            // Simulate faucet opening/closing based on probability
            if (rng.NextDouble() < device.UsageProbability) {
                device.Flow = Math.Round(rng.NextDouble() * device.MaxFlowRate, 1);
            } else {
                device.Flow = 0;
            }
        }
    }
}