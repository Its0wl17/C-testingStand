using Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burgers;

public class StringBurgerBuilder : IBurgerBuilder
{
    private readonly List<string> _ingredients;
    private readonly List<string> _menusteps;

    private readonly IEnumerable<BurgersMenu> _infos;

    public StringBurgerBuilder(IEnumerable<BurgersMenu> info)
    {
        _menusteps = new List<string>();
        _infos = info;
        _ingredients = new List<string>();
    }

    public void BuildUpBun()
    {
        _ingredients.Add($"\nToasted bun with sesame");
    }

    public void BuildTomatoes()
    {
        _ingredients.Add($"\nRed spice tomatoes");
    }

    public void BuildCheese()
    {
        _ingredients.Add("\nCheese");
    }

    public void BuildOnion()
    {
        _ingredients.Add($"\nOnion rings");
    }

    public void BuildCucumber()
    {
        _ingredients.Add($"\nCucumber slices");
    }

    public void BuildCabbage()
    {
        _ingredients.Add($"\nCabbage");
    }

    public void BuildMeatCutlet()
    {
        _ingredients.Add($"\nBeef cutlet");
    }

    public void BuildDownBun()
    {
        _ingredients.Add($"\nToasted down bun");
    }

    public void BuildHeader()
    {
        _menusteps.Add($"BURGERS MENU - {DateTime.Now}\n\n");

        _menusteps.Add("\n--------------------------------------------------------------------------------------");

    }

    public void BuildBody()
    {
        _menusteps.Add(
            string.Join(Environment.NewLine,
            _infos.Select(i =>
            $"\nBurger: {i.Name} \t\tPrice: {i.Price}$ \t")));
    }

    public void BuildFooter()
    {
        _menusteps.Add("\n--------------------------------------------------------------------------------------\n");
    }

    public string BuildBurger()
    {
        return string.Join(" ", _ingredients);
    }
}