# hadoop-succinctly - Streaming with Python

A simple Hadoop mapper and reducer in Python scripts, to do a filtered word count on the input files.

Used to demonstrate Hadoop Streaming with Python for the *Hadoop Succinctly* eBook, published by Syncfusion.

To run on the accompanying Docker image, set up some sample data:

```
hadoop fs -mkdir -p /user/root/input
hadoop fs -put $HADOOP_HOME/etc/hadoop input

```

And then submit the job using the Hadoop Streaming driver:

```
hadoop jar $HADOOP_HOME/share/hadoop/tools/lib/hadoop-streaming-2.7.2.jar -input input -output output4 -mapper mapper.py -reducer reducer.py -file /haddop-succinctly/python/mapper.py -file /haddop-succinctly/python/reducer.py
```

Output can be checked using:

```
hadoop fs -cat /output4/*
```
