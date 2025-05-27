public class Manager : EmployeeBase
{
    private decimal bonus;
    private int teamSize;
    private Project currentProject;

    public decimal Bonus
    {
        get { return bonus; }
        set { bonus = value; }
    }

    public int TeamSize
    {
        get { return teamSize; }
        set { teamSize = value; }
    }

    public Project CurrentProject
    {
        get { return currentProject; }
        set { currentProject = value; }
    }

    public Manager(string name, string position, decimal bonus,
                 int teamSize, Project project)
        : base(name, position)
    {
        this.bonus = bonus;
        this.teamSize = teamSize;
        this.currentProject = project;
    }

    public override string GetDetails()
    {
        return $"МЕНЕДЖЕР: {Name}\nДолжность: {Position}\n" +
              $"Размер команды: {teamSize}\nБонус: {bonus.ToString("C")}\n" +
              $"Текущий проект:\n{currentProject.DisplayProjectInfo()}\n";
    }

    public class Project
    {
        private string projectName;
        private DateTime deadline;

        public string ProjectName
        {
            get { return projectName; }
            set { projectName = value; }
        }

        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }

        public Project(string name, DateTime deadline)
        {
            this.projectName = name;
            this.deadline = deadline;
        }

        public string DisplayProjectInfo()
        {
            TimeSpan remaining = deadline - DateTime.Now;
            return $"  Название: {projectName}\n" +
                  $"  Дедлайн: {deadline.ToString("dd.MM.yyyy")}\n" +
                  $"  Осталось дней: {(int)remaining.TotalDays}";
        }
    }
}