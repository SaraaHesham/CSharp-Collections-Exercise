# 🛒 Shopping System – C# Collections Exercise  

This project is a **console-based shopping system** built in **C#**, designed as a practical exercise in using **collections** such as `List`, `Dictionary`, and `Stack`. It allows users to manage a shopping cart by adding, removing, and checking out items, with an **undo feature** to reverse the last action.  

## 📌 Features  
- **View Available Items** – Display a list of products with their prices.  
- **Add Items to Cart** – Select products to purchase.  
- **Remove Items from Cart** – Remove selected items.  
- **View Cart** – Check the items currently in the cart along with total cost.  
- **Checkout** – Finalize the purchase and clear the cart.  
- **Undo Last Action** – Reverse the last add/remove operation using a stack.  

## 🏗️ Technologies Used  
- **C# (.NET Console Application)**  
- **Collections:**
  - `List<string>` – Stores cart items.
  - `List<Tuple<string, double>>` – Stores cart items with their names and prices.  
  - `Dictionary<string, double>` – Manages available products and prices.  
  - `Stack<string>` – Tracks user actions for the undo feature.
  
---

## 📚 Topics Covered & Learning Outcomes  

### **1️⃣ C# Collections & Data Structures**
- **`Dictionary<string, double>`** → Stores product names and their corresponding prices.  
- **`List<Tuple<string, double>>`** → Keeps track of cart items with both name and price.  
- **`Stack<string>`** → Implements an **undo feature** to reverse the last action.  

### **2️⃣ Control Flow & Error Handling**
- **Loops (`while`, `foreach`)** → Enables continuous user interaction and iterates through products.  
- **Conditional Statements (`if`, `else`)** → Validates user input and handles different shopping actions.  

### **3️⃣ User Interaction with Console Applications**
- **Reading Input (`Console.ReadLine()`)** → Captures user choices for adding/removing items.  
- **Displaying Output (`Console.WriteLine()`)** → Provides clear and formatted feedback to users.  

### **4️⃣ Stack-Based Undo Feature**
- **Push & Pop Operations** → Adds and removes actions from the `Stack<string>` to track user operations.  
- **Reversing Changes** → Uses stack logic to restore the previous state of the shopping cart.  

### **5️⃣ Procedural Programming & Code Organization**
- **Function Decomposition** → Breaking the logic into smaller functions for **better readability**:
  - `addItem()`, `removeItem()`, `viewCart()`, `Checkout()`, `undoAction()`.  
- **Modularity** → Encourages separation of concerns, making the code easier to maintain.  

### **6️⃣ Future Enhancements & Scalability**
- **Encapsulation (via OOP concepts)** → The project can be refactored by introducing `ShoppingCart` and `Product` classes.  
- **Persistence** → Could be extended to save cart data using files or a database.  
- **GUI Development** → Could be converted into a **WinForms/WPF application** for a better user experience.  

---

## 📬 Contact  
If you have any questions, suggestions, or would like to collaborate, feel free to connect with me on **[LinkedIn](https://www.linkedin.com/in/sarahesham/)**.
