using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tracksRecord
{
    //stores albums and their respective tracks in a dictionary, 
    //contains methods/functions to modify the dictionary storing them
    public class Albums
    {
        //dictionary storing albums (key string), and tracks (object containing a list)
        private Dictionary<string, Tracks> albums = new Dictionary<string, Tracks>();


        public Dictionary<string, Tracks> getAlbums() {
            return albums;
        }

        public void setAlbums(Dictionary<string, Tracks> albumsIn) {
            albums = albumsIn;
        }

        //checks if dictionary contains the passed key, if not, it adds the key and a new Tracks() object to the dictionary
        public bool addAlbum(string albumName) {

            if (!albums.ContainsKey(albumName)){
                albums.Add(albumName, new Tracks());
                return true;
            }

            //returns false if albums contains the passed key
            return false;
        }

        //deletes passed key from the dictionary, returns true/false to indicate success/failure
        public bool delAlbum(string albumName) {
            return albums.Remove(albumName);
        }


        //checks if dictionary contains the passed key, returns true if so, false if not
        public bool searchAlbum(string albumName) {
            return albums.ContainsKey(albumName);
        }
    }


    //object that stores tracks, and uses methods/functions to modify them
    public class Tracks {

        //stores list of tracks for each instance of the object
        private List<string> tracks = new List<string>();


        public List<string> getTracks() {
            return tracks;
        }

        public void setTracks(List<string> tracksIn) {
            tracks = tracksIn;
        }

        //adds passed string to list
        public void addTrack(string trackName) {
            tracks.Add(trackName);
        }

        //removes passed string from list, returns true/false on success/fail
        public bool delTrack(string trackName) {
            return tracks.Remove(trackName);
        }

        //checks if passed string is in the list, returns true/false on success/fail
        public bool findTrack(string trackName) {
            return tracks.Contains(trackName);
        }

    }
}
