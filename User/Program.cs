using System.Diagnostics.Metrics;

Dictionary<string, int> myDict = new Dictionary<string, int>();
myDict.Add("Apple", 5);
myDict.Add("Banana", 3);

// כך סורקים אותו
foreach (var pair in myDict)
{
    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
}
Dictionary<string, int> HighScores =  new Dictionary<string, int>();
HighScores.Add("NinjaMan", 9500);
HighScores.Add("CodeQueen", 12000);
HighScores.Add("PixelPal", 7200);
HighScores["NinjaMan"] = 9900;


if (HighScores.ContainsKey("Shadow"))
{
    Console.WriteLine($"Shadow score: : {HighScores["Shadow"]}");
}
else Console.WriteLine(" Shadow has no score yet");
   foreach (KeyValuePair<string,int> pair in HighScores)
{
    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
}
if (HighScores.ContainsKey("PixelPall"))
{
    HighScores.Remove("PixelPall");
}
foreach (var pair in HighScores)
{
    Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
}