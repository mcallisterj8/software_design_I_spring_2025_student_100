public class Box<T> {
    public required string Name { get; set; }
    public required T FeaturedItem { get; set; }
    public List<T> ItemList { get; set; } = new List<T> {};

    public override string ToString() {
        string output = $"{this.Name} | Featured Item: {this.FeaturedItem}\n{this.Name} ItemList:\n";

        foreach (T elem in this.ItemList) {
            output += $"{elem}\n";
        }

        return output;
    }



    
}