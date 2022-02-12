/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
	
	DECLARE @Start_Date DATETIME ='2022-02-10 0:0:0.0';
	DECLARE @End_Date DATETIME ='2022-02-20 23:59:59.999';
	declare @id int=1;
	declare @min_integer tinyint =   1
	,@max_integer tinyint =  20
	,@time_stamp tinyint =  1
	,@time_stamp_range tinyint =  59
	,@value_range tinyint =  30
	,@count int = 1;
		while (@id >=1 and @id <= 100)
			begin
				while (@Start_Date < @End_Date)
					begin
						while (@time_stamp >=1 and @time_stamp <= 10)
							begin
								insert into [dbo].[Reading]([BuildingId], ObjectId,[DataFieldId], [Value],[Timestamp])
								values (@id, 
									floor(rand()*(@max_integer - @min_integer + 1) + @min_integer),
									floor(rand()*(@max_integer - @min_integer + 1) + @min_integer), 
									floor(rand()*(@value_range - 5 + 1) + @min_integer),
									DATEADD(SECOND, floor(rand()*(@time_stamp_range - @min_integer + 1) + @min_integer), @Start_Date)
									)
								select @time_stamp = @time_stamp + 1;
							end
						select @time_stamp = 1;
						set @Start_Date = DATEADD(MI,1, @Start_Date);
					end
			set @Start_Date = '2022-02-10 0:0:0.0';
			select @id = @id + 1;
			end
	set @id =1;
	set @count = 1;

	