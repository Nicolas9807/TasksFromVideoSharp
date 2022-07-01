char[]  numArr = Console.ReadLine().TrimStart('-','0').ToCharArray();
int office = 0;
int noOffice = 0;

for (int i = 0;i<numArr.Length;i++)
{ 
    office += Convert.ToInt32(numArr[i]) % 2 == 0 ? 1 : 0;
    noOffice += Convert.ToInt32(numArr[i]) % 2 != 0 ? 1 : 0;
}
Console.WriteLine(office>noOffice?"2":office<noOffice?"1":"0");