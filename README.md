### SchoolManagementApp


## Create a dotnet project

# `dotnet new mvc -o SchoolManagementApp.MVC`

## Run project

# `dotnet run`

## Change of profile

# `dotnet run --launch-profile https`

## Watch

# `dotnet watch`


## Install Package

# `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`
# `dotnet add package Microsoft.EntityFrameworkCore.Design`

## Install Tool

# `dotnet tool install --global dotnet-ef`

## Add scaffold and Context DB, and generate the file Data

# ` dotnet ef dbcontext scaffold "Server=localhost, 1433;Database=SchoolManagementDb;Trusted_Connection=false;MultipleActiveResultSets=true;Encrypt=false;user id=sa;password=Blizzard2604*" Microsoft.EntityFrameworkCore.SqlServer -o Data -f --no-onconfiguring`

