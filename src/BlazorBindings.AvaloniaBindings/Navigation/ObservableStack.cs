using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BlazorBindings.AvaloniaBindings.Navigation;

public class ObservableStack<T> : ObservableCollection<T>//, INotifyCollectionChanged, INotifyPropertyChanged, IList, IList<T>
{
    public bool IsFixedSize => false;
    public bool IsReadOnly => false;

    //public T this[int index] 
    //{
    //    get => base.ToArray()[index];// this.ElementAt(index); 
    //    set => throw new NotSupportedException(); 
    //}

    //object IList.this[int index]
    //{
    //    get => this.ToArray()[index];//.ElementAt(index);
    //    set => throw new NotSupportedException();
    //}

    #region Constructors

    public ObservableStack() : base() { }

    public ObservableStack(IEnumerable<T> collection) : base(collection) { }

    //public ObservableStack(int capacity) : base(capacity) { }

    #endregion

    #region Overrides

    public virtual T Pop()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Cannot pop empty collection");
        }

        var item = this.Last();
        Remove(item);

        //OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);

        return item;
    }

    public virtual bool TryPop(out T item)
    {
        if (Count == 0)
        {
            item = default;
            return false;
        }

        item = this.LastOrDefault();

        Remove(item);

        //OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);

        return true;
    }

    public virtual bool TryPeek(out T item)
    {
        if (Count == 0)
        {
            item = default;
            return false;
        }

        item = this.LastOrDefault();

        //OnCollectionChanged(NotifyCollectionChangedAction.Remove, item);

        return true;
    }

    public virtual void Push(T item)
    {
        //base.Push(item);
        Add(item);

        //OnCollectionChanged(NotifyCollectionChangedAction.Add, item);
    }

    public virtual void Clear()
    {
        base.Clear();
        //OnCollectionChanged(NotifyCollectionChangedAction.Reset, default);
    }

    #endregion

    #region CollectionChanged

    //public virtual event NotifyCollectionChangedEventHandler CollectionChanged;

    //protected virtual void OnCollectionChanged(NotifyCollectionChangedAction action, T item)
    //{
    //    CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(
    //        action
    //        , item
    //        , item == null ? -1 : 0)
    //    );

    //    OnPropertyChanged(nameof(Count));
    //}

    #endregion

    #region PropertyChanged

    //public virtual event PropertyChangedEventHandler PropertyChanged;

    //protected virtual void OnPropertyChanged(string proertyName)
    //{
    //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proertyName));
    //}

    //public int Add(object value)
    //{
    //    throw new NotImplementedException();
    //}

    //public bool Contains(object value)
    //{
    //    throw new NotImplementedException();
    //}

    //public int IndexOf(object value)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Insert(int index, object value)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Remove(object value)
    //{
    //    throw new NotImplementedException();
    //}

    //public void RemoveAt(int index)
    //{
    //    throw new NotImplementedException();
    //}

    //public int IndexOf(T item)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Insert(int index, T item)
    //{
    //    throw new NotImplementedException();
    //}

    //public void Add(T item)
    //{
    //    throw new NotImplementedException();
    //}

    //public bool Remove(T item)
    //{
    //    throw new NotImplementedException();
    //}

    #endregion
}
