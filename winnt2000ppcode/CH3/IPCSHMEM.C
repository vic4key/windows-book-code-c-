// ****************************************************************************
//
// Module:  ipcshmem.C
// Author:  Dick Lam
//
// Purpose: C++ class source file for ipcSharedMemory
//
// Notes:  This is a base class.  It is the interface class for
//         creating and accessing a memory block that is sharable between
//         processes and threads.
//
// ****************************************************************************

#include "ipcshmem.h"
#include "osshmem.h"

// ****************************************************************************

// ipcSharedMemory - constructor for creating

ipcSharedMemory::ipcSharedMemory(const char *name, long blocksize)

{
   // init instance variables
   myState = good;
   myImpl = new osSharedMemory(this, name, blocksize);
   if (!myImpl)
      myState = bad;
}

// ----------------------------------------------------------------------------

// ipcSharedMemory - constructor for accessing

ipcSharedMemory::ipcSharedMemory(const char *name)

{
   // init instance variables
   myState = good;
   myImpl = new osSharedMemory(this, name);
   if (!myImpl)
      myState = bad;
}

// ----------------------------------------------------------------------------

// ~ipcSharedMemory - destructor

ipcSharedMemory::~ipcSharedMemory()

{
   delete myImpl;
}

// ----------------------------------------------------------------------------

// Name - returns the name of the memory block

char *ipcSharedMemory::Name() const

{
   if (!myImpl)
      return 0;

   return myImpl->Name();
}

// ----------------------------------------------------------------------------

// Pointer - returns a pointer to the start of the memory block

void *ipcSharedMemory::Pointer() const

{
   if (!myImpl)
      return 0;

   return myImpl->Pointer();
}

// ----------------------------------------------------------------------------

// Owner - returns 1 if this is the owner (creator), and 0 otherwise

int ipcSharedMemory::Owner() const

{
   if (!myImpl)
      return 0;

   return myImpl->Owner();
}

// ****************************************************************************

// end of ipcshmem.C
