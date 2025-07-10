## Created a project called  TodoApp

✅ **Next Step: Make a Todo Model**

---

📌 **What is a Model?**  
A Model is a C# class that holds data.  
In our case, each **Todo** has:
- an **Id** (number)
- a **Title** (what to do)
- an **IsDone** flag (done or not)

---

🗂️ **1️⃣ Add the Model**

➡️ **In Solution Explorer**:  
- Right-click your project → **Add** → **New Folder** → name it `Models`.  
- Right-click `Models` → **Add** → **Class** → name it `Todo.cs`.


- ## ✅ What did you do in Step 1?

**Step 1 → You made the Todo Model.**  
A **Model** is just a C# class that describes the shape of your data.

👉 This means:  
> *"I have a Todo thing. Each Todo has:*  
> - *an **Id** (number)*  
> - *a **Title** (text)*  
> - *an **IsDone** flag (true or false)"*

---

## 📌 What did you do in Step 2?

**Step 2 → You used the Controller to make real Todo data using the Model.**

In the `HomeController`:
- You made **3 Todo objects**.
- Put them in a `List<Todo>`.
- Sent that list to the **View**.

So, in simple words:  
- ✅ **Model:** defines what a Todo is.  
- ✅ **Controller:** creates real Todos with data.  
- ✅ **Controller:** sends that data to the View.

## ✅✅✅ Step 4: Add Create Todo

---

📌 **1️⃣ Add a Create action in your `HomeController`**

Open your `HomeController.cs` and add this under the **Index** and **Privacy** actions:


## 📝 Prepare the View for the Create Action

---

➡️ **Right-click** `Views/Home` → **Add** → **New Item** → **Razor View** → name it `Create.cshtml`

📌 **Put this in `Create.cshtml`:**

## 🔗 The `<p>` Link in `Index.cshtml`

---

Your code:

```html
<p>
    <a asp-action="Create">Add New Todo</a>
</p>

