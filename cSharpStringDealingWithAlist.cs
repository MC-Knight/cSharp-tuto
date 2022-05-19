string number = "0781789374";

var phone = new List<string> {};

foreach (var n in number){
    phone.Add(n.ToString());
}

foreach (var i in phone){
    Console.Write($"{i}");
}
Console.WriteLine();

var a = $"{phone[0]}{phone[1]}{phone[2]}";
var b = $"{phone[3]}{phone[4]}{phone[5]}";
var c = $"{phone[6]}{phone[7]}{phone[8]}{phone[9]}";

Console.WriteLine($"{a} {b} {c}");
