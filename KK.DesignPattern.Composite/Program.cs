namespace KK.DesignPattern.Composite;

public static class Program
{
    public static void Main()
    {
        // 1. Root of the tree
        var menu = new MenuCategory("MAIN MENU");

        // 2. Main Categories
        var breakfasts = new MenuCategory("BREAKFASTS");
        var lunches = new MenuCategory("LUNCHES");
        var dinners = new MenuCategory("DINNERS");
        var drinks = new MenuCategory("DRINKS");

        menu.Add(breakfasts);
        menu.Add(lunches);
        menu.Add(dinners);
        menu.Add(drinks);

        // --- LUNCHES: Sub-categories (Meat, Fish, Veggie) ---
        var meatDishes = new MenuCategory("Meat Dishes");
        var fishDishes = new MenuCategory("Fish Dishes");
        var veggieDishes = new MenuCategory("Vegetarian");

        lunches.Add(meatDishes);
        lunches.Add(fishDishes);
        lunches.Add(veggieDishes);

        // Adding items (Leaves) to Lunch sub-categories
        meatDishes.Add(new MenuItem("Grilled Ribeye Steak", 45.99));
        meatDishes.Add(new MenuItem("Chicken Breast with Herbs", 24.50));

        fishDishes.Add(new MenuItem("Pan-Seared Salmon", 32.00));
        fishDishes.Add(new MenuItem("Fish & Chips", 18.50));

        veggieDishes.Add(new MenuItem("Mushroom Risotto", 22.00));
        veggieDishes.Add(new MenuItem("Tofu Stir-fry", 19.99));

        // --- DRINKS: Sub-categories (Soft Drinks, Cocktails) ---
        var softDrinks = new MenuCategory("Soft Drinks");
        var cocktails = new MenuCategory("Cocktails");

        drinks.Add(softDrinks);
        drinks.Add(cocktails);

        // Adding items (Leaves) to Drink sub-categories
        softDrinks.Add(new MenuItem("Fresh Orange Juice", 6.50));
        softDrinks.Add(new MenuItem("Still Water", 3.00));

        cocktails.Add(new MenuItem("Classic Mojito", 14.00));
        cocktails.Add(new MenuItem("Espresso Martini", 16.50));

        // --- BREAKFASTS: Quick add ---
        breakfasts.Add(new MenuItem("Scrambled Eggs", 12.00));
        breakfasts.Add(new MenuItem("Club Sandwich", 15.00));

        // --- DINNERS: Quick add ---
        dinners.Add(new MenuItem("Chef's Special Pasta", 28.00));

        // 3. Display the whole structure recursively
        menu.Display();

    }
}