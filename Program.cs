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
        /// Show available task options
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
        

        string UserInput = Console.ReadLine();
        return Convert.ToInt32(UserInput);
    }

void ShowMenuDelete()
{
    try
    {
        Console.WriteLine("Ingrese el número de la tarea a remover: ");
        
        ShowMenuTaskList();

        string UserInput = Console.ReadLine();
        // Remove one position because the array start in 0
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
    catch (Exception)
    {
        Console.WriteLine("Ha ocurrido un error al tratar de eliminar la tarea");
        
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
   
    if (TaskList?.Count > 0)
    {
        Console.WriteLine("----------------------------------------");
        int indexTask = 1;
        TaskList.ForEach(p => Console.WriteLine($"{indexTask++}. {p}"));

        Console.WriteLine("----------------------------------------");

        
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

