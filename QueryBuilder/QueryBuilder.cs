class QueryBuilder
{
    private string message;

    public QueryBuilder Select(string columns)
    {
        message += "SELECT " + columns;
        return this; 
    }
    public QueryBuilder From(string table)
    {
        message += " FROM " + table;
        return this; 
    }
    public QueryBuilder Where(string condition)
    {
        message += " WHERE " + condition;
        return this; 
    }
    public QueryBuilder OrderBy(string columns)
    {
        message += " ORDER BY " + columns;
        return this; 
    }

    public string Build()
    {
        return message;
    }
}
