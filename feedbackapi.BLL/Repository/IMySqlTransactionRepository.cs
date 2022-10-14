namespace feedbackapi.BLL.Repository
{
    public interface IMySqlTransactionRepository
    {
        int ExecuteSqlQuery(string rawTSql);
    }
}
