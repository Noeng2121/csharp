using System;
using System.Collections.Specialized;

public class Rectangle
{
	//instance file
	protected double _width = 0.0;
	protected double _lenght = 0.0;

	//instance method
	public double GetWidth() {  return _width; }
	public double GetHeight() => _lenght;//ដូចគ្នានឹង​return ខាងលើដែរ
	public double GetArea() => _width * _lenght;

	public string GetInfo() => $"{_width,8:n2} {_lenght,8:n2} {GetArea(),8:n2}";

	public bool SetData(string data, string separator = " ")
	{
		string[] sides = data.Split(separator);
		if(sides.Length < 2 ) return false;
		//if (sides.lenght < 2) return false;
		if (double.TryParse(sides[0],out double width)==false) return false;
		if (double.TryParse(sides[1],out double lenght)==false) return false;
		_width = width;
		_lenght = lenght;
		return true;

	}
	//static method
	public static string GetHeading() => $"{"width",8} {"lenght",8} {"area",8}";

	public static string GetBar(char c) => new string(c, 27);

}
