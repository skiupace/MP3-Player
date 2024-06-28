using System;

namespace MP3_Player.Classes.MyGenericCollections {
    public class Vector<T> {
        public Vector() {
            length = 0;
            capacity = 5;
            array = new T[capacity];
        }

        public Vector(uint capacity) {
            length = 0;
            this.capacity = capacity;
            array = new T[this.capacity];
        }

        public ushort GetSize() {
            return length;
        }

        public uint GetCapacity() {
            return capacity;
        }

        public bool IsEmpty() {
            return GetSize() == 0;
        }

        public T ValueAt(ushort index) {
            return array[index];
        }

        public void PushBack(T value) {
            if (length == capacity) Resize();
            array[length++] = value;
        }

        public T PopBack() {
            if (length > 0) length--;
            return array[length];
        }

        private void Resize() {
            capacity *= 2;
            ushort indexIterator = 0;
            T[] newArray = new T[capacity];

            foreach (T value in array)
                newArray[indexIterator++] = value;
            array = newArray;
        }

        public void PrintElements() {
            if (IsEmpty())
                Console.WriteLine("Can't Print from an Empty Vector...");
            else {
                for (ushort i = 0; i < GetSize(); ++i)
                    Console.WriteLine($"Value: {array[i]}");
            }
        }

        public void Clear() {
            length = 0;
        }

        private T[] array;
        private ushort length;
        private uint capacity;
    }
}
