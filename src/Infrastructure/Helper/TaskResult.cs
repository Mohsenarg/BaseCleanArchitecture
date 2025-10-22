using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Helper;

public sealed class TaskResult
{
    public dynamic? Result { get; set; }

    public IList<string> Errors { get; }

    public TaskResult()
    {
        Errors = new List<string>();
    }

    public bool Success => Errors.Count == 0;

    public void AddError(string error)
    {
        Errors.Add(error);
    }

    public void AddErrors(TaskResult result)
    {
        foreach (string error in result.Errors)
        {
            AddError(error);
        }
    }

    public string ErrorsMessage()
    {
        return Errors.Aggregate("", (current, error) => current + error + "\n");
    }
}

