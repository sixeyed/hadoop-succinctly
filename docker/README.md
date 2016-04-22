# hadoop-succinctly

Docker image to accompany the forthcoming Syncfusion eBook: *Hadoop Succinctly*.

A built image is available on the Docker Hub, 

Tags:

- 2.7.2: Contains Hadoop 2.7.2, and is the image used for code samples in the book.
- latest: currently the same as 2.7.2, but will be updated with newer releases of Hadoop.

To code along with the book, launch a container using:

```
docker run -it --rm -p 50070:50070 -p 50010:50010 -p 8088:8088 -p 8042:8042 -p 19888:19888 -h hadoop --name hadoop sixeyed/hadoop-succinctly:2.7.2
```

And ideally add a line in your `hosts` file, pointing the 'hadoop' name to your Docker engine's IP address, so the links in the YARN Web UIs work correctly. E.g. for a Linux installation:

```
hadoop     127.0.0.1
```

For Windows or Mac, you'll need to use the IP address of the VM running Docker.

