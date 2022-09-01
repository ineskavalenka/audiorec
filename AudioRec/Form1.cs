// https://www.c-sharpcorner.com/UploadFile/f9f215/how-to-minimize-your-application-to-system-tray-in-C-Sharp/
// https://www.youtube.com/watch?v=-6bvqwVYwMY
// http://opensebj.blogspot.com/2009/04/naudio-tutorial-5-recording-audio.html
// https://ourcodeworld.com/articles/read/702/how-to-record-the-audio-from-the-sound-card-system-audio-with-c-using-naudio-in-winforms

using System;
using System.IO;
using System.Windows.Forms;
using AudioRec.Properties;
using NAudio.Wave;

namespace AudioRec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            stop_in.Enabled = false;
            stop_out.Enabled = false;
        }

        public string OutputDir
        {
            get
            {
                if (Directory.Exists(DefaultOutputDir))
                    return DefaultOutputDir;

                var d = $"rec";
                if (!Directory.Exists(d))
                    Directory.CreateDirectory(d);

                return d;
            }
        }

        public static string DefaultOutputDir => Settings.Default.OutputDir;
        public string GetFilenameIn => $"{DateTime.Now:yyyyMMdd-HHmmss}_in.wav";
        public string GetFilenameOut => $"{DateTime.Now:yyyyMMdd-HHmmss}_out.wav";

        private WaveFileWriter outputWriter;
        private WasapiLoopbackCapture CaptureInstance;
        private void start_out_Click(object sender, EventArgs e)
        {
            CaptureInstance = new WasapiLoopbackCapture();
            outputWriter = new WaveFileWriter(Path.Combine(OutputDir, GetFilenameOut), CaptureInstance.WaveFormat);

            CaptureInstance.DataAvailable += (s, a) =>
            {
                outputWriter.Write(a.Buffer, 0, a.BytesRecorded);
            };

            CaptureInstance.RecordingStopped += (s, a) =>
            {
                outputWriter.Dispose();
                outputWriter = null;
                CaptureInstance.Dispose();
            };

            start_out.Enabled = false;
            stop_out.Enabled = true;

            CaptureInstance.StartRecording();
        }
        private void stop_out_Click(object sender, EventArgs e)
        {
            CaptureInstance?.StopRecording();

            start_out.Enabled = true;
            stop_out.Enabled = false;
        }

        WaveIn inputStream;
        WaveFileWriter inputWriter;

        private void start_in_Click(object sender, EventArgs e)
        {
            inputStream = new WaveIn
            {
                DeviceNumber = 0,
                WaveFormat = new WaveFormat(8000, 1)
            };

            inputWriter = new WaveFileWriter(Path.Combine(OutputDir, GetFilenameIn), inputStream.WaveFormat);

            inputStream.DataAvailable += (s, a) =>
            {
                inputWriter.Write(a.Buffer, 0, a.BytesRecorded);
            };

            inputStream.RecordingStopped += (s, a) =>
            {
                inputStream.Dispose();
                inputStream = null;
                inputWriter.Close();
                inputWriter = null;
            };

            inputStream.StartRecording();

            start_in.Enabled = false;
            stop_in.Enabled = true;
        }

        private void stop_in_Click(object sender, EventArgs e)
        {
            start_in.Enabled = true;
            stop_in.Enabled = false;
            inputStream?.StopRecording();
        }
    }
}
