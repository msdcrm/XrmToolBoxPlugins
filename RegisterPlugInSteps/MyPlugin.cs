using System.ComponentModel.Composition;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace RegisterPlugInSteps
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Register Plugin Steps"),
        ExportMetadata("Description", "Plugin includes registering new plugin assembly or updating existing plugin assembly and registers plugin steps with corresponding images from given registry xml file."),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAkCAIAAABnia+1AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAKmSURBVEhLY/hPYzDULHjy7NWu/aeXrN5d0z5vz66jQBHq+0BI2YdB0JaB17K5dzGQS5MgYmBQYuC32bLrOIgNEaIiYGDgffXmA4eow9VbD0BciCi1AAMD3/XbDyHst+8/gUQgHKoABgb+S1fvQjkwQDULGBiEzly8BWS0TVgKEYEA6ljAwCB6+ORlICMyrUlWJxgiCAFUsICBQXLPwTNARnxOOwOnuYVHFkQcAii1gIFBZuvOY0BGUl4nA5+1sKqfuXsmRAoCKLKAgUF23eaDQEZSXgfQdEntYCEVX6pZwMCgsGz1biAjOb8LYrqEVhDVLADm1flLtgIZKQUI06lmAQOD2sz5G2FsfUltkNFUs4CBQat/2kooB8jltoKbTgULGBj0OvqXABliGoFQEW5Liiw4dvpq99QVGQXdpo4pDAxSjZ3zgYIeYWXA9A5RQIIFpy/c6Jq8HGSWQzIDhwUDgzADg4GOZVxydnv7xGXHTl2BKGvrXczAY8Uu7QrhkmBBflFvUnZb7/RVp87fgAohgZt3Hq3fdqSuYz4DmwnQIDYp0i0Agg+fvpw8d23+8u2NXQvSi/t0rONPnr0GFBdS8gaGCaOoI5esu4R2EDACyLGARcSRgd2UQciOVcKZS9aDT9GLgcPs+OmrQCkDx2RgGQA3hUwLVE1jRNT9kVUDq70TZ0A+0HdIFqLcAhWTaGE1hClANGoBGIxaMJgsQMsHwDqEQcAWkpMNHFAymrhmIKIs4rFCqQ+AdbIHDguAxQADlzmweoIifmsGBtUDRy8ApcQ1A4BFBUKK1wpYz0B0gZqhcHEg4jBTMAyHSEEAwgJgo+z85dsXrtyBo5Pnrn/9+h0odeXGfTSpMxegBeKJs9eQxc9dun3tJqhJCgcIC2gEaGzB//8AJWXc8ua2AaUAAAAASUVORK5CYII="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "iVBORw0KGgoAAAANSUhEUgAAAFAAAABQCAIAAAABc2X6AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAWBSURBVHhe7Zp7UBVVHMePhApc3u9HPmBQRDNnahru5cpb3iho6pRaWBnxyEJqRNJIXgKCiMgjKEFQgxBFSRE1Hj5QMQIym8hCYCZEBdRRR3RMTr9lT3Bb7nC59s / d7Xzn + 8fu9 + yZ3c + cc / acs / ci / D8TBRa6KLDQRYGFLgrMWz0bGiJH44p / wIXfVG / e9vW6yLSAVTGvuIdYzV / xgpk7QvNIsSLxD3hw8AkydJlq6aln429ou9h4dqCJXaD2DF9SrEh87dIall7GdoHmc5eBjWYtsZcEkwJF4vEYVjf3MLNfCsD6NgE + KzeSVJH4Chwckaw5zRtGr + mcIJ0ZvmGfZpACReIl8JqwJGTgrDvTr6OrZ5KJK4zn5MwDpEyR + AccEpWO9J0mm3s8ffoXnPbeGkBoQenhWrZUoXgGDLMRQ2vhMfRsdNa93PLr6YZmcqJIfAL++LPdQKtm4jb4 + AmJlBdvgDdsyUZ6C9XN3B88fESi5xI / gKPj85GuFBm5PPxvtCAeAH + evAfpSJGx6 / 0Ho7QNjW3kSEmpOnBcWjHScUQGTgN37pMIY1hFR8XmkBMlpdLA6TllSNsRGTr / 2dtHIoxXhcQjTYekzP3kXEmpLvCOvHIkksCL6sbNfhJh / GZIgpqpm9Y0b6EB5xd / x9DqSv / o7CER0H7A0MLiWWjAeUVHGVodx46uGySCnszQurPbI0EBF5fVMLRakqvtnSTC + O3wbSO0ggIu + fYk0mba9hcZWtgqwOpqhFY4wAerGpCWGJq35co1EgFtaKKayWjbCge48vg5pCmGSQh2AiTC + K1wbtuy5j3wsVMXYWqFtm1s + plEZNzKoQXzGxh2dmxPrjvXQiKM31mfOkle27LmMTBDC22rJa49 + yOJMF67PmUcWjBfgaEDI5EYaKFLk4hpW6B15RByzEvg85euMDOQpkP1900kGpb2dF8TuyAOIcf8A4aJh9kVaIorqhpI9I + AVmjAzW3tzP5WJC6rrCORjIQGDEsoZtyKJLCEZBPZzRBIUMDtv3czu3mReG / pCTZ5NPjYYt7r7DEr4QB3dPYw41Ykga0fiTCGR58rXUtOhsVv4L7 + e / XnW3MKK6Nic6dYLALarK8OkTKM7SXBmi96LXBdR86HxRvg2 / 13G4Btz5GPYrLcgiKt5i9Hhi5AyHxtZK3 + akZeObkaY783ooHWcNYSHgD3D9w7c6Ett / BIRPQu96VRli8tR0YuzPJwhA0Gqo5UzyZA7BMOC4ntu0uPn7rY2d1L6mO8MS6fXUupKPCFH66GRKV7LIuCm3HZYFjqSvWs / R28w4AtLbsMlk0dXaPfZcaq9HAtVGEfXUWBS8pOIvQyszDSW6hn4 +/ gxbClZpVWn750vXv0K8xE1PLTNXhLs7 / rglUU + FbfXVgSXZf5wjQR9fT2n6htglEdk1CwOjRR4hMBM9Bki0UjtGB + jGGObt6 + 09z2W / nR + pRdByqqzpAU44joTOjwGlZeouk + utZ + BraLje0CZWnBKgoMs0tza / vBqoadX1Z8Epu74r2tUr8P4T08xdITOjkycoU3EDPr6Dtt2JxN6mC8KaEAUDnPyrGKAq98Nw4GHiDBRCKa7qtr7c801 + xA0zn / ai7A2xRfQOrwGvj9yHSdmX6cu441BabAY0yBKbA8U2AlRIHliQLLNwWmwGNMgSmwPFNgJUSB5YkCyzcFpsBjTIFVA3hNaBIycoHbjG9k4Bwp89Uycks2JJxrOFY397B9bTWpMCwNK6 + plp6cyzhG + k6xqYWkgpKaEPChY2e3bt + btHP / +P4itaimdvQPGzV1lyHhXMNxQnqJ7O + JoMQd + xIz9nEu4zg2pai + sZVUUFITAhaSKLDQRYGFLgosdFFgYQvjvwHzR +/ DrT760QAAAABJRU5ErkJggg =="),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new RegisterPlugins();
        }
    }
}