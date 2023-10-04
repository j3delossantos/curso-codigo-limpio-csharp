/*
using System;
using System.Collections.Generic;
*/

   
List<string> TaskList  = new List<string>();

                
    int activeMenu = 0;
    do
    {
        activeMenu = ShowMainMenu();
        if ((Menu)activeMenu == Menu.Add)
        {
            ShowMenuAdd();
        }
        else if ((Menu)activeMenu == Menu.Remove)
        {
            ShowMenuDelete();
        }
        else if ((Menu)activeMenu == Menu.List)
        {
            ShowMenuTaskList();
        }
    } while ((Menu)activeMenu != Menu.Exit);
        
        /// <summary>
        /// Show the main menu 
        /// </summary>
        /// <returns>Returns option indicated by user</returns>
int ShowMainMenu()
    {
        Console.WriteLine($"----------------------------------------\n" +
            $"Ingrese la opción a realizar: \n" +
            $"1. Nueva tarea \n" +
            $"2. Remover tarea\n" +
            $"3. Tareas pendientes\n" +
            $"2. 4. Salir");
        

        // Read line
        string UserInput = Console.ReadLine();
        return Convert.ToInt32(UserInput);
    }

void ShowMenuDelete()
{
    try
    {
        Console.WriteLine("Ingrese el número de la tarea a remover: ");
        // Show current taks
        ShowMenuTaskList();

        string UserInput = Console.ReadLine();
        // Remove one position
        int indexToRemove = Convert.ToInt32(UserInput) - 1;

        if (indexToRemove > (TaskList.Count -1) || indexToRemove < -0) 
        {
            Console.WriteLine("El número seleccionado esta fuera de rango");

        }
        else
        {
            if (indexToRemove > -1 && TaskList.Count > 0)
            {
                string taskToDelete = TaskList[indexToRemove];
                TaskList.RemoveAt(indexToRemove);
                Console.WriteLine($"Tarea {taskToDelete} eliminada");
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ha ocurrido un error al tratar de eliminar la tarea");
        //ex.Message
    }
}

void ShowMenuAdd()
{
try
{
    Console.WriteLine("Ingrese el nombre de la tarea: ");
    string newTask = Console.ReadLine();
    TaskList.Add(newTask);
    Console.WriteLine("Tarea registrada");
}
catch (Exception)
{
}
}

void ShowMenuTaskList()
{
    //if (TaskList == null || TaskList.Count == 0)
    if (TaskList?.Count > 0)
    {
        Console.WriteLine("----------------------------------------");
        int indexTask = 1;
        TaskList.ForEach(p => Console.WriteLine($"{indexTask++}. {p}"));

        Console.WriteLine("----------------------------------------");

        /*
        for (int i = 0; i < TaskList.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + TaskList[i]);
        }
        */
    }
    else
    {
        
        Console.WriteLine("No hay tareas por realizar");

    }
}

    

public enum Menu
{
    Add = 1,
    Remove = 2,
    List = 3,
    Exit = 4
}

