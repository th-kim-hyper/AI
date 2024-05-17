using System.Collections.Generic;
using Tensorflow;
using Tensorflow.Keras;
using static Tensorflow.Binding;
using System.IO;
using Tensorflow.Keras.Engine;
using System;
using Tensorflow.NumPy;

namespace TensorFlowNET.Examples
{
    /// <summary>
    /// Simple hello world using TensorFlow
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            var hello = tf.constant("Hello, TensorFlow!");
            Console.WriteLine(hello + ":"  + tf.VERSION);

            // Create a tensor holds a scalar value
            var t1 = new Tensor(3);

            // Init from a string
            var t2 = new Tensor("Hello! TensorFlow.NET");

            // Tensor holds a ndarray
            var nd = new NDArray(new int[] { 3, 1, 1, 2 });
            var t3 = new Tensor(nd);

            Console.WriteLine($"t1: {t1}, t2: {t2}, t3: {t3}");

        }
    }
}
