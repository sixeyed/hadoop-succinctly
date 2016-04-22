# hadoop-succinctly - Simple MapReduce in Java

A simple Hadoop mapper and reducer, to do a filtered word count on the input files.

Used to demonstrate native Java MapReduce for the *Hadoop Succinctly* eBook, published by Syncfusion.

The project uses Maven, and if you open the folder in Visual Studio Code, there is a task set up to build it with the Ctrl-Shift-B shortcut. You don't need to build it if you use the accompanying Docker image - which already has the JAR installed.

To run it, set up some sample data in HDFS:

```
hadoop fs -mkdir -p /user/root/input
hadoop fs -put $HADOOP_HOME/etc/hadoop input

```

And then submit the job:

```
hadoop jar /hadoop-succinctly/java/wordcount-1.0-SNAPSHOT.jar input output2
```

Output can be checked using:

```
hadoop fs -cat /output2/*
```


