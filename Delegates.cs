public class MyClass {
	readonly List<string> _names = new List<string>();

	public event Action<MyClass, string> NameAdded;
	public event Action<MyClass, string> NameRemoved;

	public void AddName(string name) {
		_names.Add(name);
		NameAdded?.Invoke(this, name);
	}

	public void RemoveName(string name) {
		if (_names.Remove(name)) NameRemoved?.Invoke(this, name);
	}
}

// ------

myInstance.NameAdded += (sender, name) => Console.WriteLine($"Name was added: {name}");
myInstance.NameRemoved += (sender, name) => Console.WriteLine($"Name was removed: {name}");
