/*
^V>>VVVV^>^V<><>VV<<>VVVV^>>><<<^<^^<>^^>VV^<^^<><VVV^V^V^>^^<^>><<>>VV>V>V^V^>VV<V^>^>V>VV<>V^>^>VV<<^>V<^<<V<^>><^<<^<V^VV^^<<VV<>V^V>V>V>>^VVV^V<^^^V>>>^V^^>^><<V^<^^^>^^>>>^^V^V>^V^<^>^<VVVV<^^V<<>>^<>>^VVV<>V><><^>>>^>>^V>V<V<<^^^V><VV<<<V>V<VVV>^^<<<>>VV>^>^^<>V><>>><>><^>^VV^V><><V>^>V>><><^VV>>>^^V^VVV<V>^^V^V^>^^^>^^>^V^>><V>V^<V<V>V<V><<^V<VV^^>^^^<><><V>^VVVVV><><>>^V><>VV^<<>VV<<V<>>V^<>V<V<<^<^>^^>V>><>^>>>V<<>^<<>V<VVV^^<VV^V>^<^^V<^VV<<^V<V><V>VV>V><<<^<V>VV^<<>VV^><^V<V^<<VV^>><V
The rover is 16m to the East and 24m to the South
Linear distance = 28.84m, Manhattan distance = 40m

^2^3^^1^>6<4>VV3^8>^4^V^1^3V3>3<V<>V<8V^2^V>^<<V5^<9V<>^1VV7^6V>V<8<6VVV4V<^7V<6V^6^^>V3>8<VV>^VV^1^V5VV<1<VVV8<<4>8>>6<5V<<4>6>4<4V>^<6<<V3>4VV<>V6^^V><<V1^>2V^V6>^V7<V9>5>6>8>V3>V2><<8V3^^V2V5V1<^^5<>1<V^8<7>1^V5V5<<>1VV4<<<1<V8<3V2>1V^<V<6<>6>^7<<7>^V7VV<V5V>7<^^^V9<3VV5<4<^>9>1V2V5<<<1<9<6<<8^>^>>>6<1^V1^V>^4<^V1>V^7V4^1^5^2>V9^^1^<6<V<8>>8<3V5^>3<<V5V6^4>3>^^>>>4V3<7VV7><<8<2<<9V^<^<1V^<6^7<6<9V9<2>5>><2>2^2>>V1>6<^7<7>^<7>4V^>6>V^><V<7V8<^V^3>^^<^^1^6><1>V>^^V5>^<7>8>^1<V<1V7>2V1>V>^9>^5<9<2>6^9>4^4^<4^8^9<3^<V9>5^5V1V5>7V8<V^V^7<8^6V2><V7>2V>2>1V3<VV>8^9<2^3V5V3>3<>2^9<V^5>1<7<V^5^<7>^<4VV>6<^3>2>^6>>4>V3<3><>6V5^4^4<<2^4^8>5V^9^4V7>5>3<8>^>4>2V1>6<2<<6<V>2<8^VV<^1>^4<7><V3V4V<5>3^7<<>V2^5<>V^9^4^9>>1VV9>V3>5>>^VV9V3V2^V6><<^2<3<9>6
The rover is 80m to the West and 32m to the South
Linear distance = 86.16m, Manhattan distance = 112m

^>>3VV^V>V74>67V>V^^26>>78^92^^^16^48^31>V>41<V85VV88V<V9<34^^28<V4>87V92>80^63>73<^23>93>^48V25VVV59V^<^^^70V<8VV<3>63>V73^30>>90>34V21V5>36<73<89<<>39^<44>80^61VV>28VV64>^<51>6>>^57<30V<12^VV8V<V72V41^20<75^78<34V>^55^9<V>93^^>19>62^70VV<34<4V<>^><50>^<<V37^67^^>><58V<83<V43V44<>41^><42>>V97^61<19^>88V30<>66<75>V>48<62^38>8^30<78V1>76<35V73>30V<VV55V<>69>24V>66>^2^<93<><><>79>22^^<56V87^>>69>38<<^^82<^79^><99V57<<32^>28<35<^>70^>1<V79<V85^93^V>^63V88<85^55<<82><1>6V2^>84^83>77^V>38<VVV^61<^82^V71V<59<>67<89V<5>>V78<<19>>^<<50^1^>>>^97>V7^<<22>21<<86^86V68<>^^28^33^>76V^V76^^>^86V^^>>86^^95<<97^>34V75V<<<52^83<93<59V28<>74<44^V<>41>^<>75<28>>20V97<^V77^V^^71V>^32<>V<<^62^^2^>29<52^V65<>^V16<>V60>74<51V<82V<47VV8V47<75^2^79<V66^50^90V<^77<V57V35<9^^^><66>26>85V54V73<49>^65>^29V^72<34V28>10<58<92^68^VV^90><^16>53V^90>41^>79^V45>31<<<38>48^89^48^52V17VV<76V^99^V>80^32V1<8<<^27^15^^<><90^33<V62V53>18>^<>V77^V>60>67>V45^>59<45>52^76>4<>64V6^V<15V^V84^37<69^31<<32>29V69V74<11^
The rover is 317m to the East and 456m to the North
Linear distance = 555.36m, Manhattan distance = 773m
*/

using System.Text;

var sb = new StringBuilder();
for(var i = 0; i < 500; i++)
{
    sb.Append(Random.Shared.Next(4) switch {
        0 => '>',
        1 => '<',
        2 => '^',
        3 => 'V',
        _ => throw new InvalidOperationException()
    });
    if (Random.Shared.Next(2) == 0)
    {
        sb.Append(Random.Shared.Next(1, 100));
    }
}

Console.WriteLine(sb.ToString());

var movementLog = sb.ToString();

int x = 0, y = 0;
while (movementLog.Length > 0)
{
    var direction = movementLog[0];
    movementLog = movementLog.Substring(1);
    var distance = 1;
    if (movementLog.Length > 0 && char.IsAsciiDigit(movementLog[0]))
    {
        var nextDirection = movementLog.IndexOfAny(new[] { '>', '<', '^', 'V' });
        if (nextDirection == -1)
            nextDirection = movementLog.Length;
        distance = int.Parse(movementLog.Substring(0, nextDirection));
        movementLog = movementLog.Substring(nextDirection);
    }

    switch (direction)
    {
        case '>': x += distance; break;
        case '<': x -= distance; break;
        case '^': y += distance; break;
        case 'V': y -= distance; break;
    }
}

var eastWest = x > 0 ? "to the East" : "to the West";
var northSouth = y > 0 ? "to the North" : "to the South";
Console.Write("The rover is ");
if (x != 0)
{
    Console.Write($"{Math.Abs(x)}m {eastWest}");
    if (y != 0)
    {
        Console.Write(" and ");
    }
}

if (y != 0)
{
    Console.Write($"{Math.Abs(y)}m {northSouth}");
}

if (x == 0 && y == 0)
{
    Console.Write("in the base station");
}

Console.WriteLine();

var linearDistance = Math.Round(Math.Sqrt(x * x + y * y), 2);
var manhattanDistance = Math.Abs(x) + Math.Abs(y);
Console.WriteLine($"Linear distance = {linearDistance}m, Manhattan distance = {manhattanDistance}m");


