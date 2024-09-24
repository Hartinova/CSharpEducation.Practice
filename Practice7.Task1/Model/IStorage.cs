namespace Practice7.Task1.Model
{
  /// <summary>
  ///  Интерфейс, который определяет базовые операции для хранения и получения данных типа `T` в хранилище
  /// </summary>
  /// <typeparam name="T">Тип элемнтов хранилища.</typeparam>
  interface IStorage<T>
  {
    /// <summary>
    /// Добавить элемент в хранилище.
    /// </summary>
    /// <param name="item">Добавляемый элемент.</param>
    void Add(T item);

    /// <summary>
    /// Получить элемент из хранилища по указанному индексу.
    /// </summary>
    /// <param name="index">Индекс элемента.</param>
    /// <returns>Элемент из хранилища.</returns>
    T Get(int index);

    /// <summary>
    /// Общее количество элементов в хранилище.
    /// </summary>
    int Count { get; }
  }
}
