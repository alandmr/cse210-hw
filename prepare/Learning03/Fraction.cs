public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction (int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return this._top;
    }

    public void SetTop(int _top)
    {
        this._top = _top;
    }

    public int GetBottom()
    {
        return this._bottom;
    }

    public void SetBottom(int _bottom)
    {
        this._bottom = _bottom;
    }

    public string getFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double getDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }


}