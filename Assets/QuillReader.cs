using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SharpQuill; 
using System.IO;


[ExecuteAlways]
public class QuillReader : MonoBehaviour
{


    public string name;
    // Start is called before the first frame update
    void OnEnable()
    {

        var filePath = Application.dataPath +"/" + name;

        var directories = Directory.GetDirectories(filePath);
       // print(directories[0]);

        print(filePath);

        //print(""+QuillSequenceReader.Read);

           var sequence = QuillSequenceReader.Read(filePath);
        print( Directory.Exists(filePath) );
        print(sequence);


           // Create the standard default scene but without any paint layer.
    var sequence2 = Sequence.CreateDefault();

    // Insert an existing layer somewhere in the hierarchy.
    // This creates the necessary groups along the way if they don't exist.
    // The inital "/" is interpreted as the root group of the sequence.
    //sequence2.InsertLayerAt(layer, "/Group/SubGroup/SubSubGroup");

    // Export the scene to a folder.
    QuillSequenceWriter.Write(sequence2, filePath);
        //print("Background color: {0} : " +Floosequence.BackgroundColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
