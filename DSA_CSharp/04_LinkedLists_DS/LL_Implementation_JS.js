//10-->5-->16

class LinkedList {
  constructor(value) {
    (this.head = {
      value: value,
      next: null,
    }),
      (this.tail = this.head),
      (this.length = 1);
  }

  append(value) {
    const temp = {
      value: value,
      next: null,
    };

    this.tail.next = temp;
    this.tail = temp;
    this.length++;
    return this;
  }

  prepend(value) {
    //console.log('prepend',this.head)
    const newHead = {
      value: value,
      next: null,
    };
    newHead.next = this.head;
    this.head = newHead;
    this.length++;
    return this;
  }

  printList() {
    const array = [];
    let currentNode = this.head;
    while (currentNode !== null) {
      array.push(currentNode.value);
      currentNode = currentNode.next;
    }
    return array;
  }

  remove(index) {
    //Remove 1 item
    

    //Remove Item in between
    if(index > 0 && index < this.length){
      
      var prevNode = this.traverseToIndex(index - 1);
      console.log(prevNode);
      var nodeToRemove = prevNode.next;
      console.log(nodeToRemove);
      var nextNode = nodeToRemove.next;
      console.log(nextNode);
      prevNode.next = nextNode;
      console.log(prevNode.next);
      this.length--;
      this.printList();
    }
  }

  insert(index, value) {
    if (index == 0) {
      return this.prepend(value);
    }
    if (index >= this.length) {
      return this.append(value);
    }
    const newNode = {
      value: value,
      next: null,
    };

    const leader = this.traverseToIndex(index - 1);
    const holdingPinter = leader.next;
    leader.next = newNode;
    newNode.next = holdingPinter;
    this.length++;
    return this.printList();
  }

  traverseToIndex(index) {
    let counter = 0;
    let currentNode = this.head;
    while (counter !== index) {
      currentNode = currentNode.next;
      counter++;
    }
    return currentNode;
  }
}

const myLinkedList = new LinkedList(10);
myLinkedList.append(5);
myLinkedList.append(16);
myLinkedList.prepend(1);
myLinkedList.insert(2, 20);
myLinkedList.insert(20, 100);
//myLinkedList.insert(0, 2);
myLinkedList.remove(4);
console.log(myLinkedList.printList());
