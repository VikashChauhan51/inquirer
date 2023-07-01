﻿
using VInquirer.Prompts;

namespace VInquirer;
public class Inquirer
{
    public List<IPrompt> Questions { get; }

    public Inquirer(params IPrompt[] questions)
    {
        Questions = questions.ToList();
    }
    public void Ask()
    {
        Questions.ForEach(q => q.Ask());
    }

    public string[] Answers()
    {
        return Questions.Select(x => x.Answer()).ToArray();
    }
}
