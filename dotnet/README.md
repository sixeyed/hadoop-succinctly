# hadoop-succinctly - Streaming with .NET

A simple Hadoop mapper and reducer in .NET console apps, to do a filtered word count on the input files.

Used to demonstrate Hadoop Streaming with .NET for the *Hadoop Succinctly* eBook, published by Syncfusion.

Currently, this solution uses the full .NET Framework, so you'll need to run on a Windows-based Hadoop distribution. A future enhancement will port it to .NET Core and include it in the Docker image.

Build the solution, and set up some sample data in HDFS:

```
hadoop fs -mkdir -p /user/root/input
hadoop fs -put $HADOOP_HOME/etc/hadoop input

```

And then submit the job using the Hadoop Streaming driver (example using Syncfusion Big Data Studio, version 2.11.0.92):

```
hadoop jar %HADOOP_HOME%\share\hadoop\tools\lib\hadoop-streaming-2.5.2.jar -mapper "c:\hadoop-succinctly\dotnet\Sixeyed.HadoopSuccinctly.Streaming.Mapper.exe" -reducer "c:\hadoop-succinctly\dotnet\Sixeyed.HadoopSuccinctly.Streaming.Reducer.exe" -input input -output output5
```

Output can be checked using:

```
hadoop fs -cat /output5/*
```


